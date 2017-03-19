<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="Default.aspx.cs" Inherits="Gallery.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%: Styles.Render("~/bundles/css") %>

   
</head>
<body>

    <div id="header">
        <h1>Fotogalerie</h1>
    </div>
    
    <div id="bigPic">
            <asp:PlaceHolder ID="bigImgDisplay" runat="server" Visible="True">
                <asp:Image ID="bigImg" runat="server" width="700" Height="450"/>
                </asp:PlaceHolder>    
    </div>


    <div id="thumbList">
    <asp:Repeater ID="PicList" runat="server">
                <HeaderTemplate>
                    <ul>
                </HeaderTemplate>
                <FooterTemplate>
                    </ul>
                </FooterTemplate>
                <ItemTemplate>
                    <li><asp:HyperLink ID="HyperLink" runat="server" NavigateUrl='<%# String.Format("Default.aspx?img={0}", Container.DataItem)%>'>
                    <asp:Image ID="thumbs" runat="server" ImageUrl='<%# String.Format("~/Pictures/thumb/{0}", Container.DataItem)%>'/>
                    </asp:HyperLink></li>
                </ItemTemplate>
            </asp:Repeater>
    </div>

    

    <form id="uploadForm" runat="server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Es ist ein Fehler aufgetreten!" CssClass="FileUploadValidator"/>

    <div id="uploadFunction" style="font-size: small; color: #0000FF; font-family: Arial" >
        </br>Wählen Sie eine Datei zum Hochladen aus oder klicken Sie aufs Miniatürbild ...
        </br>
        <asp:FileUpload ID="PictureFileUpload" runat="server" Width="730" />
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="Eine Bilddatei muss ausgewählt werden" 
            ControlToValidate="PictureFileUpload" Text="*" CssClass="FileUploadValidator"></asp:RequiredFieldValidator>
        
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Nur Dateien mit der Erweiterung .gif, .jpg oder .png sind gültig."
            Display="Dynamic" ControlToValidate="PictureFileUpload" Text="*"  CssClass="FileUploadValidator" 
            ValidationExpression="^.*\.(gif|jpg|png)$"></asp:RegularExpressionValidator>
        
        <asp:Button ID="UploadButton" runat="server" Text="Hochladen!" OnClick="UploadButton_Click"/>
    </div>


        <asp:PlaceHolder ID="SuccessMessagePlaceHolder" runat="server" Visible="False">
               <div id="success_message"><p>Die Datei ist hochgeladen worden!</div>
        </asp:PlaceHolder>

                <asp:PlaceHolder ID="PlaceHolderEvaluate" runat="server" Visible="False">
                <div id="PlaceHolderEvaluate_message"  style="font-family: Arial; font-size: medium; color: #0000FF"><p>Datei-Inhalt wird geprüft. Haben Sie ein weing Geduld ...</div>
                </asp:PlaceHolder>

                <asp:PlaceHolder ID="NotAllowedPlaceHolder" runat="server" Visible="False">
                <div id="NotAllowed_message"  style="font-family: Arial; font-size: medium; color: #FF0000"><p>Datei ist nicht freigegeben:</div>
                </asp:PlaceHolder>

                <asp:PlaceHolder ID="NotAllowedPlaceHolder_Racy" runat="server" Visible="False">
                <div id="NotAllowedPlaceHolder_Racy_message" style="font-family: Arial; font-size: medium; color: #FF0000"><p>Rassen-Inhalt!</div>
                </asp:PlaceHolder>

                <asp:PlaceHolder ID="NotAllowedPlaceHolder_Adult" runat="server" Visible="False">
                <div id="otAllowedPlaceHolder_Adult" style="font-family: Arial; font-size: medium; color: #FF0000"><p>Nicht Jugendfrei!</div>
                </asp:PlaceHolder>

                <asp:PlaceHolder ID="NoPicturePlaceHolder" runat="server" Visible="False">
                <div id="NoPicture_message" style="font-family: Arial; font-size: medium; color: #FF0000"><p>Kein Bild gefunden bzw. ausgewählt!</div>
                </asp:PlaceHolder>
      
    </form>



    <!--<script src="Content/JScript.js"></script>-->
</body>
</html>
