$(document).ready(function () {
    //SeeDepartment()
});//刷新页面

function InsertDate() {
    $.ajax({
        url: "../General/Release.ashx",
        type: "Post",
        dataType: "get",
        data: { Action: "GetZHMM", "zhsm": zhsm, "addQxid": addQxid, },

        success: function (data) {
            //$("#jqudiv").html("");
            var HQmm = "";
            $.each(data.jsons, function (i, josn) {
                //HQmm += "<tr>";
                //HQmm += "<td name=\"zh\" style=\"text-align: center;\">" + josn.AccountNumber + "</td>";
                //HQmm += "<td name=\"mm\" style=\"text-align: center;\">" + josn.State + "</td>";
                //HQmm += "<td  style=\"text-align: center;\">"
                //    + "<div ><button class='btn btn-danger btn-sm btn-flat'  onclick='deleteById(" + josn.AccountNumber + ")'  >" + "<i class='glyphicon glyphicon-trash'>&nbsp;删除</button></div>"
                //    + "</td>";
                //HQmm += "</tr>";
            });

            $("#jqudiv").append(HQmm);

        },
        error: function (date) {
            window.parent.msg_alert('错误！');

        }
    });




};