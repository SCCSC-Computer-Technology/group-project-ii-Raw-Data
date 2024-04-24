function searchPlayers() {
    var playerName = document.getElementById('search-name').value;
    // Adjust as necessary to target your API endpoint
    fetch(`/api/sports/searchplayers?name=${encodeURIComponent(playerName)}`)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(data => {
            displayResults(data);
        })
        .catch(error => {
            console.error('Error during fetch operation:', error);
            document.getElementById('search-results').innerHTML = '<p>Error loading the search results.</p>';
        });
    function displayResults(players) {
        const resultsElement = document.getElementById('search-results');
        resultsElement.innerHTML = ''; // Clear previous results

        if (players.length > 0) {
            // Create a table and its header
            const table = document.createElement('table');
            const thead = document.createElement('thead');
            const headerRow = document.createElement('tr');
            const headers = ['Name', 'Team', 'Position'];
            headers.forEach(headerText => {
                const header = document.createElement('th');
                header.textContent = headerText;
                headerRow.appendChild(header);
            });
            thead.appendChild(headerRow);
            table.appendChild(thead);

            // Create table body
            const tbody = document.createElement('tbody');
            players.forEach(player => {
                const row = document.createElement('tr');
                row.innerHTML = `<td>${player.strPlayer}</td><td>${player.strTeam}</td><td>${player.strPosition}</td>`;
                tbody.appendChild(row);
            });
            table.appendChild(tbody);

            resultsElement.appendChild(table);
        } else {
            resultsElement.innerHTML = '<p>No players found. Try another search.</p>';
        }
    }




}