INSERT INTO Configuration.Caste(Name) VALUES('General');
INSERT INTO Configuration.Caste(Name) VALUES('SC');
INSERT INTO Configuration.Caste(Name) VALUES('ST');
INSERT INTO Configuration.Caste(Name) VALUES('OBC');

--India Pack
INSERT INTO Configuration.Country(Name, Code, IsdCode)
	VALUES('India', 'IN', '+91');

-- Andhra Pradesh Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Andhra Pradesh',(SELECT Id FROM Configuration.Country WHERE Name like 'India'));
-- Andhra Pradesh Pack - End

-- Bihar Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Bihar', (SELECT Id FROM Configuration.Country WHERE Name like 'India'));
-- Bihar Pack - End

-- Karnataka Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Karnataka', (SELECT Id FROM Configuration.Country WHERE Name like 'India'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Bangalore', (SELECT Id FROM Configuration.State where Name like 'Karnataka'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Mandia', (SELECT Id FROM configuration.State where Name like 'Karnataka'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Simoga', (SELECT Id FROM configuration.State where Name like 'Karnataka'));
-- Karnataka Pack - End

-- Gujrat Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Gujrat',(SELECT Id FROM Configuration.Country WHERE Name like 'India'));
-- Gujrat Pack - End

-- Maharastra Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Maharastra', (SELECT Id FROM Configuration.Country WHERE Name like 'India'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Mumbai', (SELECT Id FROM Configuration.State where Name like 'Maharastra'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Thane', (SELECT Id FROM Configuration.State where Name like 'Maharastra'));
-- Maharastra Pack - End

-- Orisa Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Orisa',(SELECT Id FROM Configuration.Country WHERE Name like 'India'));
-- Orisa Pack - End

-- Tamilnadu Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Tamilnadu',(SELECT Id FROM Configuration.Country WHERE Name like 'India'));
-- Tamilnadu Pack - End

-- West Bengal Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('West Bengal',(SELECT Id FROM Configuration.Country WHERE Name like 'India'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Kolkata', (SELECT Id FROM Configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('South 24 Parganas', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('North 24 Parganas', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Howrah', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Hugli', (SELECT Id FROM Configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('East Midnapur', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('West Midnapur', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Nadia', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Bardhaman', (SELECT Id FROM Configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Murshidabad', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Purulia', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Birbhum', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Darjeeling', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Jalpaiguri', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Kochbihar', (SELECT Id FROM configuration.State where Name like 'West Bengal'));
-- West Bengal Pack - End
-- India Pack - End

INSERT INTO Configuration.Gender(Name) VALUES('Male');
INSERT INTO Configuration.Gender(Name) VALUES('Female');
INSERT INTO Configuration.Gender(Name) VALUES('Other');

INSERT INTO Configuration.MotherTongue(Name) VALUES('Bengali');
INSERT INTO Configuration.MotherTongue(Name) VALUES('Gujarathi');
INSERT INTO Configuration.MotherTongue(Name) VALUES('Hindi');
INSERT INTO Configuration.MotherTongue(Name) VALUES('Kannada');
INSERT INTO Configuration.MotherTongue(Name) VALUES('Marathi');
INSERT INTO Configuration.MotherTongue(Name) VALUES('Punjabi');
INSERT INTO Configuration.MotherTongue(Name) VALUES('Tamil');
INSERT INTO Configuration.MotherTongue(Name) VALUES('Telugu');

INSERT INTO Configuration.Religion(Name) VALUES('Buddhism');
INSERT INTO Configuration.Religion(Name) VALUES('Christianity');
INSERT INTO Configuration.Religion(Name) VALUES('Hinduism');
INSERT INTO Configuration.Religion(Name) VALUES('Jainism');
INSERT INTO Configuration.Religion(Name) VALUES('Muslim');

INSERT INTO Configuration.SubCaste(Name) VALUES( 'Brahmin');
INSERT INTO Configuration.SubCaste(Name) VALUES( 'Kayasta');

INSERT INTO Student.Category(Name) VALUES('DayScholar');
INSERT INTO Student.Category(Name) VALUES('Boarder')