//I have to build a helper for sweet alert, I thnk is a nuget to isntall it but due to time I dindt research
// jsut to check is loaded
console.log("swalHelper loaded:", window.swalHelper);

window.swalHelper = {
    success: function (title, message) {
        Swal.fire({
            icon: 'success',
            title: title,
            text: message,
            confirmButtonColor: '#3085d6'
        });
    },
    error: function (title, message) {
        Swal.fire({
            icon: 'error',
            title: title,
            text: message,
            confirmButtonColor: '#d33'
        });
    },
    warning: function (title, message) {
        Swal.fire({
            icon: 'warning',
            title: title,
            text: message,
        });
    },
    info: function (title, message) {
        Swal.fire({
            icon: 'info',
            title: title,
            text: message,
        });
    }
};
