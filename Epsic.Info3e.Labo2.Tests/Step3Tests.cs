// namespace Epsic.Info3e.Labo2.Tests
// {
//     using Epsic.Info3e.Labo2.Step3;
//     using Microsoft.VisualStudio.TestTools.UnitTesting;

//     [TestClass]
//     public class Step3Tests
//     {
//         [TestMethod, TestCategory("Step3")]
//         public void DocumentNameCreatorDontHeritsCounter() 
//         {
//             var result = typeof(DocumentNameCreator).IsSubclassOf(typeof(Counter));

//             Assert.AreEqual(false, result, "DocumentNameCreator ne doit pas hériter de Counter.");
//         }

//         [TestMethod, TestCategory("Step3")]
//         public void DocumentNameCreatorDontHeritsCounte2r() 
//         {
//             var result = typeof(Counter).GetMethod("GetNewDocumentName");

//             Assert.IsNull(result, "Counter ne doit pas implémenter de GetNewDocumentName.");
//         }

//         [TestMethod, TestCategory("Step3")]
//         public void DocumentNameCreatorOneCall() 
//         {
//             var sut = new DocumentNameCreator(new Counter(5), "epsic");

//             var docName = sut.GetNewDocumentName();

//             Assert.AreEqual("epsic5", docName);
//         }

//         [TestMethod, TestCategory("Step3")]
//         public void DocumentNameCreatorTwoCalls() 
//         {
//             var sut = new DocumentNameCreator(new Counter(5), "epsic");

//             var docName = sut.GetNewDocumentName();
//             var docName2 = sut.GetNewDocumentName();

//             Assert.AreEqual("epsic5", docName);
//             Assert.AreEqual("epsic10", docName2);
//         }
//     }
// }

