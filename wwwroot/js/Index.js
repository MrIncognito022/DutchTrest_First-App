
var x = 0;
var s = "";
console.log("Hello Ahmed Qureshi");


var theForm = $("#theform");

var toggleButton = $("#toggleButton");
toggleButton.on(
    {
        "click": function () {
            theForm.toggle();
        }
    });
var button = $("#buyButton");
button.on("click", function () {
    console.log("Buying Item");
});

var productInfo = $(".product-props li");
productInfo.on("click", function () {
    console.log("You clicked on " + $(this).text());

});

