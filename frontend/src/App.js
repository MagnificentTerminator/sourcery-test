import "./App.css";
import AppNavBar from "./components/layout/AppNavBar";
import Dashboard from "./components/layout/Dashboard";

function App() {
  return (
    <div className="App">
      <AppNavBar />
      <div className="container">
        <Dashboard />
      </div>
    </div>
  );
}

export default App;
