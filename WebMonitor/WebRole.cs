using System;
using System.Diagnostics;
using System.Threading;
using Arkitektum.Kartverket.MetadataMonitor.Models;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace Arkitektum.Kartverket.MetadataMonitor
{
    public class WebRole : RoleEntryPoint
    {
        /*
        private MyWorkerThread workerThread;
        public override bool OnStart()
        {
            workerThread = new MyWorkerThread();
            Thread thread = new Thread(workerThread.Start);
            thread.Start();

            return base.OnStart();
        }

        public void OnEnd()
        {
            // End the thread
            workerThread.WaitHandle.Set();
        }
         */
    }

    class MyWorkerThread
    {
        private Timer timer { get; set; }
        public ManualResetEvent WaitHandle { get; private set; }

        private void DoWork(object state)
        {


            Trace.WriteLine("Start validating all metadata");
            try
            {
                new ValidatorService().RunValidateWithRegularSearch();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Exception while validating all metadata: " + e.Message);
            }
            Trace.WriteLine("___________Finished validating all metadata______________");
        }

        public void Start()
        {
            WaitHandle = new ManualResetEvent(false);
            timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromHours(24));

            // Wait for the end 
            WaitHandle.WaitOne();
        }
    }
}