using MvcWeb.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;

namespace MvcWeb.Models
{
    [PageType(Title = "SubPage", UseBlocks = false)]
    [PageTypeRoute(Title = "Page Phụ", Route = "/subpage")]
    public class SubPage : Page<SubPage>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Slides", ListTitle = "Slides", ListPlaceholder = "Slides")]
        public IList<Slide> SlideModel { get; set; } = new List<Slide>();

        [Region(Display = RegionDisplayMode.Full, Title = "Overview", ListTitle = "Overview", ListPlaceholder = "Overview")]
        public Overview Overview { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Location", ListTitle = "Location", ListPlaceholder = "Location")]
        public ME Location { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Products Intro", ListTitle = "Products Intro", ListPlaceholder = "Products Intro")]
        public TitleDescrip ProductsIntro { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Product Images", ListTitle = "Product Images", ListPlaceholder = "Product Images")]
        public IList<ImageField> ProductImages { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "ArchitectureIntro1", ListTitle = "ArchitectureIntro1", ListPlaceholder = "ArchitectureIntro1")]
        public TitleDescrip ArchitectureIntro1 { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "ArchitectureIntro2", ListTitle = "ArchitectureIntro2", ListPlaceholder = "ArchitectureIntro2")]
        public TitleDescrip ArchitectureIntro2 { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "ArchitectureImage1", ListTitle = "ArchitectureImage1", ListPlaceholder = "ArchitectureImage1")]
        public IList<ImageField> ArchitectureImage1 { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "ArchitectureImage2", ListTitle = "ArchitectureImage2", ListPlaceholder = "ArchitectureImage2")]
        public IList<ImageField> ArchitectureImage2 { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "UtilitiesIntro", ListTitle = "UtilitiesIntro", ListPlaceholder = "UtilitiesIntro")]
        public TitleDescrip UtilitiesIntro { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "UtilitieImages", ListTitle = "UtilitieImages", ListPlaceholder = "UtilitieImages")]
        public IList<ImageField> UtilitieImages { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Videos", ListTitle = "Videos", ListPlaceholder = "Videos")]
        public VideoField Videos { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "MainNews", ListTitle = "MainNews", ListPlaceholder = "MainNews")]
        public ImageLinkInfo MainNews { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "SubNews", ListTitle = "SubNews", ListPlaceholder = "SubNews")]
        public IList<TitleDescrip> SubNews { get; set; }
    }
}
