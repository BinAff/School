using AppCache = BinAff.Facade.Cache.Server;

namespace Sparkle.Configuration.Facade
{

    public class Cache
    {

        public static void Start()
        {
            AppCache.Current.Cache["CountryList"] = new Country.Server(null).ReadAll<Country.Dto>();
            AppCache.Current.Cache["StateList"] = new State.Server(null).ReadAll<State.Dto>();
            AppCache.Current.Cache["DistrictList"] = new District.Server(null).ReadAll<District.Dto>();
            AppCache.Current.Cache["ReligionList"] = new Religion.Server(null).ReadAll<Religion.Dto>();
            AppCache.Current.Cache["CasteList"] = new Caste.Server(null).ReadAll<Caste.Dto>();
            AppCache.Current.Cache["SubCasteList"] = new SubCaste.Server(null).ReadAll<SubCaste.Dto>();
            AppCache.Current.Cache["GenderList"] = new Gender.Server(null).ReadAll<Gender.Dto>();
            AppCache.Current.Cache["IdentityProofTypeList"] = new IdentityProofType.Server(null).ReadAll<IdentityProofType.Dto>();
            AppCache.Current.Cache["MotherTongueList"] = new MotherTongue.Server(null).ReadAll<MotherTongue.Dto>();
            AppCache.Current.Cache["OccupationList"] = new Occupation.Server(null).ReadAll<Occupation.Dto>();
            AppCache.Current.Cache["RelationshipList"] = new Relationship.Server(null).ReadAll<Relationship.Dto>();
        }

    }

}