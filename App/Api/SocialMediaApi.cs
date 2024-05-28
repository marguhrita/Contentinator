using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contentinator.Api
{
    abstract class SocialMediaApi
    {
        protected abstract void Authorisation();

        protected abstract void Upload();
    }
}
