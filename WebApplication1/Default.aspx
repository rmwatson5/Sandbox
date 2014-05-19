<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="http://documentcloud.github.com/underscore/underscore-min.js"></script>
    <script src="http://documentcloud.github.com/backbone/backbone-min.js"></script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="#" onclick="doBackbone();">Click Here</a>
            <div id="test"></div>
            <script type="text/javascript">
                doBackbone = function () {
                    var ItemModel = Backbone.Model.extend({});
                    var itemModel = new ItemModel({ itemId: '21967115', name: 'iPod' });
                    var ItemView = Backbone.View.extend({
                        render: function () {
                            var html = '<h3>' + this.model.get('name') + '</h3>';
                            $("#test").html(html);
                        }
                    });
                    var itemView = new ItemView({ model: itemModel });
                    itemView.render();
                    console.log(itemView.el);
                };
            </script>
        </div>
    </form>
</body>
</html>
