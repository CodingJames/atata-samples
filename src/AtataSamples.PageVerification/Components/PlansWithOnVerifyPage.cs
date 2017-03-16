﻿using Atata;
using _ = AtataSamples.PageVerification.PlansWithOnVerifyPage;

namespace AtataSamples.PageVerification
{
    [Url("plans")]
    public class PlansWithOnVerifyPage : Page<_>
    {
        public H1<_> Header { get; private set; }

        protected override void OnVerify()
        {
            PageTitle.Should.Equal("Plans - Atata Sample App");
            Header.Should.Equal("Plans");
            Content.Should.Contain("Please choose your payment plan");
        }
    }
}
