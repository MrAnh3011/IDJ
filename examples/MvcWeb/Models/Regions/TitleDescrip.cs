using Piranha.Extend;
using Piranha.Extend.Fields;

namespace MvcWeb.Models.Regions
{
    public class TitleDescrip
    {
        [Field]
        public StringField Title { get; set; }

        [Field]
        public StringField SubTitle { get; set; }

        [Field]
        public TextField Description { get; set; }
    }
}
