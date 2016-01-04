INSERT INTO Configuration.Caste(Name) VALUES('General');
INSERT INTO Configuration.Caste(Name) VALUES('SC');
INSERT INTO Configuration.Caste(Name) VALUES('ST');
INSERT INTO Configuration.Caste(Name) VALUES('OBC');

--India Pack
INSERT INTO Configuration.Country(Name, Code, IsdCode)
VALUES('India', 'IN', '+91');

-- Andhra Pradesh Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Andhra Pradesh',(SELECT ID FROM Configuration.Country WHERE Name like 'India'));
-- Andhra Pradesh Pack - End

-- Bihar Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Bihar', (SELECT ID FROM Configuration.Country WHERE Name like 'India'));
-- Bihar Pack - End

-- Karnataka Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Karnataka', (SELECT ID FROM Configuration.Country WHERE Name like 'India'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Bangalore', (SELECT ID FROM Configuration.State where Name like 'Karnataka'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Mandia', (SELECT ID FROM configuration.State where Name like 'Karnataka'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Simoga', (SELECT ID FROM configuration.State where Name like 'Karnataka'))
-- Karnataka Pack - End

-- Gujrat Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Gujrat',(SELECT ID FROM Configuration.Country WHERE Name like 'India'));
-- Gujrat Pack - End

-- Maharastra Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Maharastra', (SELECT ID FROM Configuration.Country WHERE Name like 'India'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Mumbai', (SELECT ID FROM Configuration.State where Name like 'Maharastra'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Thane', (SELECT ID FROM Configuration.State where Name like 'Maharastra'))
-- Maharastra Pack - End

-- Orisa Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Orisa',(SELECT ID FROM Configuration.Country WHERE Name like 'India'));
-- Orisa Pack - End

-- Tamilnadu Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('Tamilnadu',(SELECT ID FROM Configuration.Country WHERE Name like 'India'));
-- Tamilnadu Pack - End

-- West Bengal Pack
INSERT INTO Configuration.State(Name, CountryId)
	VALUES('West Bengal',(SELECT ID FROM Configuration.Country WHERE Name like 'India'));
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Kolkata', (SELECT ID FROM Configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('South 24 Parganas', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('North 24 Parganas', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Howrah', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Hugli', (SELECT ID FROM Configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('East Midnapur', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('West Midnapur', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Nadia', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Bardhaman', (SELECT ID FROM Configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Murshidabad', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Purulia', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Birbhum', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Darjeeling', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Jalpaiguri', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
INSERT INTO Configuration.District(Name, StateId)
	VALUES('Kochbihar', (SELECT ID FROM configuration.State where Name like 'West Bengal'))
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