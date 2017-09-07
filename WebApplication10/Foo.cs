using Newtonsoft.Json;

namespace WebApplication10
{
    public class Foo
    {
        public Foo()
        {
            var res = JsonConvert.DeserializeObject("foo");
        }
    }
}