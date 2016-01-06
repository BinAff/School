namespace BinAff.Core
{

    public interface IFactory
    {

        /// <summary>
        /// Create data object
        /// </summary>
        /// <returns></returns>
        Data CreateDataObject();

        /// <summary>
        /// Create new instance
        /// </summary>
        /// <param name="data">Data object</param>
        /// <returns></returns>
        Crud CreateInstance(Data data);

    }

}