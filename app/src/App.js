import { useEffect, useState } from "react";
import "./App.css";

function App() {
  let [emp, setEmp] = useState([]);

  useEffect(() => {
    fetch(process.env.REACT_APP_API)
      .then((res) => setEmp(res.json()))
      .catch((err) => console.log(err));
  }, []);

  return (
    <div className="App">
      <table>
        <thead>
          <tr>
            <th>Company</th>
            <th>Contact</th>
            <th>Country</th>
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
