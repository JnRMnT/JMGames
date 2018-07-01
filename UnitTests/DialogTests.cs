using System.Linq;
using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.Pools.DialogPools;
using JMGames.JMDialogs.Pools.ResponseItemPools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JMGames.Common.Enums;

namespace UnitTests
{
    [TestClass]
    public class DialogTests
    {
        [TestMethod]
        public void RandomGeneratorTester()
        {
            int testCount = 10;

            string dialog = string.Empty;
            bool hasDifferent = false;
            for (int i = 0; i < testCount; i++)
            {
                Dialog randomDialog = DialogFactory.GetDialogPool(DialogTypeEnum.Greeting).PickOne();
                string currentDialog = randomDialog.Items.FirstOrDefault().Content;
                if (!string.IsNullOrEmpty(dialog) && dialog != currentDialog)
                {
                    hasDifferent = true;
                }
                dialog = currentDialog;
            }

            Assert.IsTrue(hasDifferent);
        }


        [TestMethod]
        public void RandomResponseTest()
        {
            DialogResponseItem responseItem = ResponseItemFactory.GetResponseItemPool(DialogItemTypeEnum.Acceptance).PickOne();
            Assert.IsNotNull(responseItem);
            Assert.IsNotNull(responseItem.Content);
        }

        [TestMethod]
        public void Playground()
        {

        }
    }
}
