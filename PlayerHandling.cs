using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppTestingExercise
{
    [TestFixture]
    class PlayerHandling
    {
        [Test]
         public void TestPlayer()
         {
            foreach(var Pl in Program.playerList())
            {
                Assert.NotNull(Pl.PlayerId);
                Assert.NotNull(Pl.PlayerName);
                Assert.NotNull(Pl.PlayerTeam);
            }
         }
    }
}

