using DanmarksRadioXP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsTest
{
    [TestClass]
    public class RecordsValidateTest
    {
        private Records goodRecord = new Records(1, "Candy Paint", "Normani", 295, 2024);
        private Records nullTitle = new Records(2, null, "Bruno Mars", 282, 1940);
        private Records shortTitle = new Records(3, "ko", "Adele", 340, 2015);
        private Records nullArtist = new Records(4, "hey ho", null, 331, 2020);
        private Records shortArtist = new Records(5, "Wrekinf ball", "x", 420, 2003);
        private Records negativeDuration = new Records(6, "Worth It", "Fift Harmony", -1, 2017);
        private Records furtureYear = new Records(7, "Jakke", "Rosa fra roluadegade", 295, 2026);

        [TestMethod]
        public void ValidateTitle()
        {
            goodRecord.ValidateTitle();
            Assert.ThrowsException<ArgumentNullException>(() => nullTitle.ValidateTitle());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shortTitle.ValidateTitle());


        }

        [TestMethod]
        public void ValidateArtist()
        {
            goodRecord.ValidateArtist();
            Assert.ThrowsException<ArgumentNullException>(() => nullArtist.ValidateArtist());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shortArtist.ValidateArtist());
        }

        [TestMethod]
        public void ValidateDuration()
        {
            goodRecord.ValidateDuration();
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> negativeDuration.ValidateDuration());
        }

        [TestMethod]
        public void ValidatePublicationYear()
        {
            goodRecord.ValidatePublicationYear();
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> furtureYear.ValidatePublicationYear());
        }

    }
}
