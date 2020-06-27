var photos = document.querySelectorAll(".sub-photo");
var mainPhotos = document.querySelectorAll(".main-photo");

var activePhoto = "";

[].forEach.call(mainPhotos, function(photo) {
  if (photo.className.indexOf("active")>-1) {
    activePhoto = photo;
  }
});

[].forEach.call(photos, function(photo) {
  photo.addEventListener("mouseover", function() {
     var clicked=photo.id;
    clicked = "lg-" + clicked.split("-")[1];
    activePhoto.classList.remove("active");
    activePhoto = document.getElementById(clicked);
    activePhoto.classList.add("active");
  });
});