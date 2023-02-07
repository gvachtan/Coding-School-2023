const customers = [];

function addCustomer(name, surname, age, gender) {
  customers.push({ name, surname, age, gender });
}

function renderCustomers() {
  const table = document.getElementById("customers-table");
  table.innerHTML = "";
  customers.forEach((customer, index) => {
    const row = document.createElement("tr");
    row.innerHTML = `
      <td>${customer.name}</td>
      <td>${customer.surname}</td>
      <td>${customer.age}</td>
      <td>${customer.gender}</td>
    `;
    row.addEventListener("click", () => {
      renderCustomerDetails(index);
    });
    table.appendChild(row);
  });
}

function renderCustomerDetails(index) {
  const customer = customers[index];
  document.getElementById("name").value = customer.name;
  document.getElementById("surname").value = customer.surname;
  document.getElementById("age").value = customer.age;
  document.getElementById("gender").value = customer.gender;
}
