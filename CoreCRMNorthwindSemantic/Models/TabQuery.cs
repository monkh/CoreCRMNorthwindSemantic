namespace CoreCRMNorthwindSemantic.Models
{
    public class TabQuery
    {
        private string _queryKey;
        private string _queryValue;

        public string GetQueryKey()
        {
            return _queryKey;
        }

        public void SetQueryKey(string value)
        {
            _queryKey = value;
        }

        public string GetQueryValue()
        {
            return _queryValue;
        }

        public void SetQueryValue(string value)
        {
            _queryValue = value;
        }
    }
}