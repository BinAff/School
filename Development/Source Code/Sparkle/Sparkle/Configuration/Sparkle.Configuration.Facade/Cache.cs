using System.Threading.Tasks;

using AppCache = BinAff.Facade.Cache.Server;

namespace Sparkle.Configuration.Facade
{

    public class Cache
    {

        public static void Start()
        {
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["CountryList"] = new Country.Server(null).ReadAll<Country.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["StateList"] = new State.Server(null).ReadAll<State.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["DistrictList"] = new District.Server(null).ReadAll<District.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["ReligionList"] = new Religion.Server(null).ReadAll<Religion.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["CasteList"] = new Caste.Server(null).ReadAll<Caste.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["SubCasteList"] = new SubCaste.Server(null).ReadAll<SubCaste.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["GenderList"] = new Gender.Server(null).ReadAll<Gender.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["IdentityProofTypeList"] = new IdentityProofType.Server(null).ReadAll<IdentityProofType.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["MotherTongueList"] = new MotherTongue.Server(null).ReadAll<MotherTongue.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["OccupationList"] = new Occupation.Server(null).ReadAll<Occupation.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["RelationshipList"] = new Relationship.Server(null).ReadAll<Relationship.Dto>();
            });
        }

    }

}