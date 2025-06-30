window.initializeThemeToggle = function () {
    const isDark = getCookie("theme") === "dark";
    const toggle = document.getElementById("theme-toggle");

    if (toggle) {
        toggle.checked = isDark;

        toggle.addEventListener("change", function () {
            const darkMode = toggle.checked;
            setCookie("theme", darkMode ? "dark" : "light", 365);
            location.reload();
        });
    }
};