import { useEffect, useState } from "react";
import "./App.css";

function App() {
  let [emp, setEmp] = useState([]);
  const api = process.env.REACT_APP_API;

  useEffect(() => {
    fetch(`${api}/Employee`)
      .then((res) => res.json())
      .then(function (parsedData) {
        console.log(parsedData);
        setEmp(parsedData);
      })
      .catch((err) => console.log(err));
  }, []);

  return (
    <div className="App">
      <table>
        <thead>
          <tr>
            <th>FirstName</th>
            <th>LastName</th>
            <th>designation</th>
          </tr>
        </thead>
        <tbody>
          {emp.map((e) => {
            return (
              <tr key={e.employeeId}>
                <td>{e.employeeFirstName}</td>
                <td>{e.employeeLastName}</td>
                <td>{e.designation}</td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </div>
  );
}

export default App;
