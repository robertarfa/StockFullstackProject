import React, { useEffect, useState } from "react";
import PizzaList from "./PizzaList";

const term = "Pizza";
const API_URL = "/Pizza";
const headers = {
  "Content-Type": "application/json",
};

export default function Pizza() {
  const [data, setData] = useState([]);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetchPizzaData();
  }, []);

  const fetchPizzaData = () => {
    // Simulate fetching data from API

    fetch(API_URL)
      .then((response) => response.json())
      .then((data) => {
        console.log(data);

        setData(data);
        // setMaxId(Math.max(...data.map((pizza) => pizza.id)));
      })
      .catch((error) => setError(error)); // outputs mocked data
  };

  const handleCreate = (item) => {
    console.log(`add item: ${JSON.stringify(item)}`);

    fetch(API_URL, {
      method: "POST",
      headers,
      body: JSON.stringify({ name: item.name, description: item.description }),
    })
      .then((response) => response.json())
      .then((returnItem) => setData([...data, returnItem]))
      .catch((error) => setError(error));
  }; // outputs mocked data);

  const handleUpdate = (updatedItem) => {
    console.log(`update item: ${JSON.stringify(updatedItem)}`);

    fetch(`${API_URL}/${updatedItem.id}`, {
      method: "PUT",
      headers,
      body: JSON.stringify(updatedItem),
    })
      .then(() =>
        setData(
          data.map((item) => (item.id === updatedItem.id ? updatedItem : item))
        )
      )
      .catch((error) => setError(error));
  };

  const handleDelete = (id) => {
    fetch(`${API_URL}/${id}`, {
      method: "DELETE",
      headers,
    })
      .then(() => setData(data.filter((item) => item.id !== id)))
      .catch((error) => setError(error));
    // const updatedData = data.filter((pizza) => pizza.id !== id);
    // setData(updatedData);
  };

  return (
    <div>
      <PizzaList
        name={term}
        data={data}
        error={error}
        onCreate={handleCreate}
        onUpdate={handleUpdate}
        onDelete={handleDelete}
      />
    </div>
  );
}
