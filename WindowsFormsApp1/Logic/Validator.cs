﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Validator
    {
        public bool ValidateIfStringNotNull (string text)
        {
            if(text =="")
            {
                throw new ApplicationException("Fälten får ej vara tomma");
            }

            return true;
        }

    public bool ValidateUrl(string url)
        {
            Uri uriResult;

            if(Uri.TryCreate(url, UriKind.Absolute,out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                return true;
            }

            else
            {
                throw new ApplicationException("Länken är ej giltig");
            }
        }
    }
}
