CREATE TABLE metadata (
	uuid VARCHAR(255) PRIMARY KEY,
	title VARCHAR(255),
	responsible_organization VARCHAR(255),
	resourcetype VARCHAR(255),
	inspire_resource BOOLEAN DEFAULT false
);

CREATE TABLE validation_results (
	id SERIAL PRIMARY KEY,
	uuid VARCHAR(255) REFERENCES metadata(uuid),
	result INTEGER DEFAULT -1,
	timestamp TIMESTAMP DEFAULT now(),
	messages TEXT
);