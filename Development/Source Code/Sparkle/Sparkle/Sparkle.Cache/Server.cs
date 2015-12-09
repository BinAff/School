using AppCache = BinAff.Facade.Cache.Server;

using Conf = Sparkle.Configuration.Facade;
using Schl = Sparkle.School.Facade;

namespace Sparkle.Cache
{

    public class Server
    {

        public void Cache()
        {
            AppCache.Current.Cache["CountryList"] = new Conf.Country.Server(null).ReadAll<Conf.Country.Dto>();
            AppCache.Current.Cache["StateList"] = new Conf.State.Server(null).ReadAll<Conf.State.Dto>();
            AppCache.Current.Cache["DistrictList"] = new Conf.District.Server(null).ReadAll<Conf.District.Dto>();
            AppCache.Current.Cache["ReligionList"] = new Conf.Religion.Server(null).ReadAll<Conf.Religion.Dto>();
            AppCache.Current.Cache["CasteList"] = new Conf.Caste.Server(null).ReadAll<Conf.Caste.Dto>();
            AppCache.Current.Cache["SubCasteList"] = new Conf.SubCaste.Server(null).ReadAll<Conf.SubCaste.Dto>();
            AppCache.Current.Cache["GenderList"] = new Conf.Gender.Server(null).ReadAll<Conf.Gender.Dto>();
            AppCache.Current.Cache["IdentityProofTypeList"] = new Conf.IdentityProofType.Server(null).ReadAll<Conf.IdentityProofType.Dto>();
            AppCache.Current.Cache["MotherTongueList"] = new Conf.MotherTongue.Server(null).ReadAll<Conf.MotherTongue.Dto>();
            AppCache.Current.Cache["OccupationList"] = new Conf.Occupation.Server(null).ReadAll<Conf.Occupation.Dto>();
            AppCache.Current.Cache["RelationshipList"] = new Conf.Relationship.Server(null).ReadAll<Conf.Relationship.Dto>();

            AppCache.Current.Cache["StandardList"] = new Schl.Standard.Server(null).ReadAll<Schl.Standard.Dto>();
            AppCache.Current.Cache["SectionList"] = new Schl.Section.Server(null).ReadAll<Schl.Section.Dto>();
        }

    }

}