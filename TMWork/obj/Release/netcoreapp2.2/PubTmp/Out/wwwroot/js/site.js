// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function busyLoadShow() {
    $.busyLoadFull("show", { spinner: "accordion", text: "LOADING ...", minSize: "100px", maxSize: "100px", fontSize: "2rem" });
}
function busyLoadHide() {
    $.busyLoadFull("hide");
}