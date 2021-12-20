// side menu transition
$('#menu-button').on('click', function (e) {
  e.stopPropagation();
  $('#hide-menu').toggleClass('show-menu');
  $('#body-overlay').toggle();
  // $('body').css('overflow', 'hidden');
});
$('#hide-menu').on('click', function (e) {
  e.stopPropagation();
});
$('body,html, #close_menu').on('click', function (e) {
  $('#hide-menu').removeClass('show-menu');
  $('#body-overlay').hide();
  // $('body').css('overflow', 'visible');
});

$('.menu-link').on('click', function () {
  $('nav').removeClass('show-menu');
  $('#body-overlay').hide();
});
$('.dropdown').on('click', function () {
  $(this).toggleClass('show');
  $('.dropdown-menu').toggleClass('show');
});

$('#upload_file').on('change', function () {
  // let i = $(this).prev('label').clone();
  let file = $('#upload_file')[0].files[0].name;
  $(this).prev('label').text(file);
});

// var elements = document.getElementById('s');

// var seconds = new ProgressBar.Circle(elements, {
//   duration: 200,
//   color: '#F47621',
//   trailColor: '#8E8782',
//   strokeWidth: 8,
//   trailWidth: 8,
// });

// if (localStorage.getItem('counter')) {
//   if (localStorage.getItem('counter') >= 45) {
//     var value = 0;
//   } else {
//     var value = localStorage.getItem('counter');
//   }
// } else {
//   var value = 0;
// }
// var counter = function () {
//   if (value >= 45) {
//     localStorage.setItem('counter', 0);
//     value = 0;
//     alert('Done');
//   } else {
//     value = parseInt(value) + 1;
//     localStorage.setItem('counter', value);
//     var second = Math.floor(value);
//     seconds.animate(second / 45, function () {
//       seconds.setText('<span class="number">' + second);
//     });
//   }
// };

// var interval = setInterval(function () {
//   counter();
// }, 1000);
