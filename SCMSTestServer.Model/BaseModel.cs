﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SCMSTestServer.Models
{
    public class BaseModel
    {
        /// <summary>
        /// The ID fiels for every Object
        /// </summary>
        [Required(ErrorMessage = "ID cannot be null for this Object")]
        public string ID
        {
            get;
            set;
        }

        #region Methods

        /// <summary>
        /// This method validates all the Properties of this class
        /// </summary>
        /// <returns>
        /// returns any error message (if any)
        /// </returns>
        protected virtual string Validate()
        {
            var errorMessage = new StringBuilder();

            var context = new ValidationContext(this, null, null);
            var results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(this, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult vr in results)
                {
                    errorMessage.AppendLine(vr.ErrorMessage);
                }

                return errorMessage.ToString();
            }

            return null;
        }

        #endregion Methods
    }
}