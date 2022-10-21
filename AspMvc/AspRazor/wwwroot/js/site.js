$('.select2').select2({ theme: 'bootstrap4', });
$('.select2-multi').select2(
    {
        multiple: true,
        theme: 'bootstrap4',
    });
$('.drgpicker').daterangepicker(
    {
        singleDatePicker: true,
        timePicker: false,
        showDropdowns: true,
        locale:
        {
            format: 'YYYY/MM/DD'
        }
    });

$('.time-input').timepicker(
    {
        'scrollDefault': 'now',
        'zindex': '9999' /* fix modal open */
    });

/** date range picker */
if ($('.datetimes').length) {
    $('.datetimes').daterangepicker(
        {
            timePicker: true,
            startDate: moment().startOf('hour'),
            endDate: moment().startOf('hour').add(32, 'hour'),
            locale:
            {
                format: 'M/DD hh:mm A'
            }
        });
}
var start = moment().subtract(29, 'days');
var end = moment();

$('.input-placeholder').mask("0000/00/00",
    {
        placeholder: "____/__/__"
    });

$('.input-zip').mask('00000-000',
    {
        placeholder: "____-___"
    });

$('.input-money').mask("#.##0,00",
    {
        reverse: true
    });

$('.input-phoneus').mask('(000) 000-0000');
$('.input-mixed').mask('AAA 000-S0S');

$('.input-ip').mask('0ZZ.0ZZ.0ZZ.0ZZ',
    {
        translation:
        {
            'Z':
            {
                pattern: /[0-9]/,
                optional: true
            }
        },
        placeholder: "___.___.___.___"
    });

// Example starter JavaScript for disabling form submissions if there are invalid fields
(function () {
    'use strict';
    window.addEventListener('load', function () {
        // Fetch all the forms we want to apply custom Bootstrap validation styles to
        var forms = document.getElementsByClassName('needs-validation');
        // Loop over them and prevent submission
        var validation = Array.prototype.filter.call(forms, function (form) {
            form.addEventListener('submit', function (event) {
                if (form.checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                }
                form.classList.add('was-validated');
            }, false);
        });
    }, false);
})();

var uptarg = document.getElementById('drag-drop-area');
if (uptarg) {
    var uppy = Uppy.Core().use(Uppy.Dashboard,
        {
            inline: true,
            target: uptarg,
            proudlyDisplayPoweredByUppy: false,
            theme: 'dark',
            width: 770,
            height: 210,
            plugins: ['Webcam']
        }).use(Uppy.Tus,
            {
                endpoint: 'https://master.tus.io/files/'
            });
    uppy.on('complete', (result) => {
        console.log('Upload complete! We’ve uploaded these files:', result.successful)
    });
}

window.dataLayer = window.dataLayer || [];

function gtag() {
    dataLayer.push(arguments);
}
gtag('js', new Date());
gtag('config', 'UA-56159088-1');