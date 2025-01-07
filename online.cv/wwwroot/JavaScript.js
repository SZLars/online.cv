// Bootstrap JavaScript
const script = document.createElement('script');
script.src = "https://stackpath.bootstrapcdn.com/bootstrap/5.1.3/js/bootstrap.bundle.min.js";
document.head.appendChild(script);

// CAPTCHA 
document.addEventListener('DOMContentLoaded', function () {
    const form = document.querySelector('form');
    form.addEventListener('submit', function (event) {
        const captchaInput = document.getElementById('captcha');
        const captchaValue = captchaInput.value.trim();
        if (captchaValue !== '5') { // corret answer is 5
            event.preventDefault();
            alert('Incorrect CAPTCHA answer. Please try again.');
        }
    });
});
