﻿CREATE TABLE metadata (
	uuid VARCHAR(255) PRIMARY KEY,
	title VARCHAR(255),
	responsible_organization VARCHAR(255),
	resourcetype VARCHAR(255),
	inspire_resource BOOLEAN DEFAULT false,
	active BOOLEAN DEFAULT true,
	keywords TEXT,
	contact_information TEXT,
	abstract TEXT,
	purpose TEXT
);

CREATE TABLE validation_results (
	id SERIAL PRIMARY KEY,
	uuid VARCHAR(255) REFERENCES metadata(uuid),
	result INTEGER DEFAULT -1,
	timestamp TIMESTAMP DEFAULT now(),
	messages TEXT
);


// endring 17.10.2013
ALTER TABLE metadata ADD COLUMN active BOOLEAN DEFAULT true;

// endring 29.10.2013
ALTER TABLE metadata ADD COLUMN keywords TEXT;
ALTER TABLE metadata ADD COLUMN contact_information TEXT;
ALTER TABLE metadata ADD COLUMN abstract TEXT;
ALTER TABLE metadata ADD COLUMN purpose TEXT;


# rettigheter
GRANT CONNECT ON DATABASE XXXXXXXXX to monitor;
GRANT USAGE ON SCHEMA public to monitor;
GRANT SELECT ON ALL SEQUENCES IN SCHEMA public TO monitor;
GRANT SELECT ON ALL TABLES IN SCHEMA public TO monitor;