Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass> _
Public Class SampleTest
    <TestMethod> _
    Public Sub TestSay()
        Dim sample = New Sample()
        Assert.AreEqual("Hello TDD Boot Camp!", sample.Say())
    End Sub
End Class
