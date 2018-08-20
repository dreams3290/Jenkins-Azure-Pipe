using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jenkins_Azure_Pipe.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}