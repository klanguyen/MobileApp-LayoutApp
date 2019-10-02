using System;
using System.Collections.Generic;

namespace HW6App
{
    public class PageDataViewModel
    {
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
                new PageDataViewModel(typeof(CalculatorGrid), "Calculator",
                                        "Using Grid Layout")
                new PageDataViewModel(typeof(Catalog), "Keychain Catalog",
                                        "Using Flex Layout"),
                /*new PageDataViewModel(typeof(NameOfPage), "Title",
                                        "desclaimer")*/
            };
        }

        public static IList<PageDataViewModel> All { private set; get; }
    }
}