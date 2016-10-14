using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCFExercise.Models
{
    public class ConversionModel
    {
        [Required(ErrorMessage = "{0} field is required.")]
        public double weight { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        public string weightType { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        public double weightResult { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        public double height { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        public string heightType { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        public double heightResult { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        public double bmiweight { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        public double bmiheight { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        public string bmiResult { get; set; }

    }
}