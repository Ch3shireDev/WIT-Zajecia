const samochdyTable = document.getElementById('samochody')
samochdyTable.style.display = 'none'

/**
 * Podłączenie zdarzenia click do przycisku pobierz
 */
document.getElementById('btn-pobierz').addEventListener('click', async () => {
    const resp = await fetch('pobierz.php')
    const json = await resp.json()

    json.forEach(s => pokazSamochod(s))
    samochdyTable.style.display = ''
})

/**
 * Podłączenie zdarzenia click dla przycisku pokaż szczegóły
 */
document.body.addEventListener('click', (e) => {
    if (e.target.matches('[data-id]')) {
        const id = e.target.dataset.id

        pokazSzczegoly(id)
    }
})

/**
 * Wyświetla dane pojedyńczego samochodu w tabeli HTML.
 */
function pokazSamochod(samochod) {
    const { id, marka, model, rok, pojemnosc } = samochod

    const wiersz = `
        <tr>
            <td>${id}</td>
            <td>${marka}</td>
            <td>${model}</td>
            <td>${rok}</td>
            <td>${pojemnosc}</td>
            <td><button class="btn btn-link" data-id="${id}">pokaż szczegóły</button>
        </tr>
    `
    const template = document.createElement('template')
    template.innerHTML = wiersz.trim()
    samochdyTable.querySelector('tbody').appendChild(template.content.firstChild)
}

/**
 * Pokazuje szczegóły samochodu.
 *
 * @param {string} id
 */
function pokazSzczegoly(id) {
    alert('Szczegóły samochodu o ID: ' + id)
}
