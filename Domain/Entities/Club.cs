using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Club
    {
        public int Id { get; set; }

        public string Name { get; set; }

        #region Validations
        public void Validate()
        {
            ValidateName();
        }

        private void ValidateName()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new Exception("Please, inform a name.");

            if (Name.Length <= 3)
                throw new Exception("Name should have at least 3 chars.");

            if (Name.Length >= 100)
                throw new Exception("Name should have no more than 100 chars.");
        }
        #endregion
    }
}
