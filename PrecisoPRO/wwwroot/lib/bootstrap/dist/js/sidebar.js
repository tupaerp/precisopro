const body = document.querySelector('body'),
    sidebar = body.querySelector('nav'),
    toggle = body.querySelector(".toggle"),
    searchBtn = body.querySelector(".search-box"),
    modeSwitch = body.querySelector(".toggle-switch"),
    modeText = body.querySelector(".mode-text"),
    modeImg = body.querySelector(".mode-img");




toggle.addEventListener("click", () => {
    sidebar.classList.toggle("close");

})

searchBtn.addEventListener("click", () => {
    sidebar.classList.remove("close");

})
  


modeSwitch.addEventListener("click", () => {
    body.classList.toggle("dark");

    if (body.classList.contains("dark")) {
        modeText.innerText = "Modo Claro";
        modeImg.innerHTML = '<img src="lib/IMG/LOGOMENOR2.png" width="190" />';
        
    } else {
        modeText.innerText = "Modo Escuro";
        modeImg.innerHTML = '<img src="lib/IMG/LOGOMENOR.png" width="190" />';

    }
});