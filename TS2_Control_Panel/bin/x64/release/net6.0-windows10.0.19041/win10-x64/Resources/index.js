const div = document.getElementById('test')

function edit(text) {
    div.innerHTML = text
    console.log(text)
    return text
}
