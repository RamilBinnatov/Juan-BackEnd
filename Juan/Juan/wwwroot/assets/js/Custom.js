
//(function ($) {
//    $(document).on("click", ".salamlar", function () {


//        let productIdRemove = parseInt($($(this).closest(".nsx")[0]).attr('id'));

//        let dataRemove = { id: productIdRemove };

//        $.ajax({
//            url: "/basket/RemoveFromCart",
//            type: "POST",
//            data: dataRemove,
//            contentType: "application/x-www-form-urlencoded",
//            success: function (res) {
//            }
//        })
//    });
//    $(document).on("click", ".salam1231", function () {
//        console.log("fsdfds")

//        let productId = parseInt($($(this).closest(".supraaaa")[0]).attr('id'));

//        let data = { id: productId };

//        $.ajax({
//            url: "/home/addbasket",
//            type: "POST",
//            data: data,
//            contentType: "application/x-www-form-urlencoded",
//            success: function (res) {
//                swal({
//                    type: 'success',
//                    title: 'Product added',
//                    showConfirmButton: false,
//                    timer: 1000
//                });
//            }
//        })


//    });

//    $(document).on("click", ".salam12321", function () {

//        let productId = parseInt($($(this).closest(".godzilla")[0]).attr('id'));

//        let data = { id: productId };

//        $.ajax({
//            url: "/home/addbasket",
//            type: "POST",
//            data: data,
//            contentType: "application/x-www-form-urlencoded",
//            success: function (res) {
//                swal({
//                    type: 'success',
//                    title: 'Product added',
//                    showConfirmButton: false,
//                    timer: 1000
//                });
//            }
//        }

//	});

//}(jQuery));