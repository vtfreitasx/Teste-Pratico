const entitySelect = document.getElementById("entitySelect");
const loadButton = document.getElementById("loadButton");
const resultDiv = document.getElementById("result");

loadButton.addEventListener("click", () => {
    const selectedEntity = entitySelect.value;
    fetch(`https://swapi.dev/api/${selectedEntity}/`)
        .then(response => response.json())
        .then(data => {
            const items = data.results;
            const table = createTable(items);
            resultDiv.innerHTML = "";
            resultDiv.appendChild(table);
        })
        .catch(error => console.error("Erro ao carregar dados:", error));
});

function createTable(items) {
    const table = document.createElement("table");
    const thead = document.createElement("thead");
    const tbody = document.createElement("tbody");
    const keys = Object.keys(items[0]);

    const headerRow = document.createElement("tr");
    keys.forEach(key => {
        const th = document.createElement("th");
        th.textContent = key;
        headerRow.appendChild(th);
    });
    thead.appendChild(headerRow);

    items.forEach(item => {
        const row = document.createElement("tr");
        keys.forEach(key => {
            const td = document.createElement("td");
            td.textContent = item[key];
            row.appendChild(td);
        });
        tbody.appendChild(row);
    });

    table.appendChild(thead);
    table.appendChild(tbody);
    return table;
}
