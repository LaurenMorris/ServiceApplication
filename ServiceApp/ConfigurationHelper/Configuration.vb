Public Class Configuration
    'function to read datasystems.config file (gets connection string)
    Public Shared Function GetConnectionString(ByVal name As String) As String
        Dim connstring As String = String.Empty
        'find path of executable file
        Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        ' path minus the file name ( where datasystems.config lives)
        path = System.IO.Path.GetDirectoryName(path)
        path = path + "\" + "datasystems.config"

        'create an xml document with datasystems.config and load the document from the path
        Dim xmldoc As New System.Xml.XmlDocument
        xmldoc.Load(path)

        'creates an xml node list
        Dim xmlNodeList As System.Xml.XmlNodeList
        xmlNodeList = xmldoc.SelectNodes("//configuration/connectionStrings/add")
        ' loop through list to find name that matches 
        ' the name that was passed in
        For Each node As Xml.XmlNode In xmlNodeList
            If node.Attributes("name").Value.ToUpper = name.ToUpper Then
                connstring = node.Attributes("connectionString").Value
                Exit For
            End If
        Next
        ' return corresponding connection string
        Return connstring

    End Function
End Class
