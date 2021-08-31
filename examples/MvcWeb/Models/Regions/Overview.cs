using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace MvcWeb.Models.Regions
{
    public class Overview
    {
        [Field]
        public ImageField Image { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title1 { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title2 { get; set; }

        [Field]
        public TextField Content1 { get; set; }

        [Field]
        public HtmlField Content2 { get; set; }
    }
}
