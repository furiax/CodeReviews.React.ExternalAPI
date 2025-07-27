import { useState, useEffect } from "react";
import Driver from "./Driver.jsx";
import Modal from "./Modal.jsx";

export default function Body() {
  const [drivers, setDrivers] = useState(null);
  const [selectedDriver, setSelectedDriver] = useState(null);

  useEffect(() => {
    fetch("https://localhost:7215/api/Formula")
      .then((res) => res.json())
      .then((data) => {
        setDrivers(data);
        console.log("data:", data);
      });
  }, []);

  const handleDriverClick = (driver) => {
    setSelectedDriver(driver);
  };

  return (
    <>
      <div className="drivers-grid">
        {drivers ? (
          drivers.map((driver) => (
            <div
              key={driver.id}
              onClick={() => handleDriverClick(driver)}
              style={{ cursor: "pointer" }}
            >
              <Driver
                number={driver.driverNumber}
                name={driver.driverName}
                team={driver.team}
                driverImage={driver.driverImageLink}
                carImage={driver.carImageLink}
              />
            </div>
          ))
        ) : (
          <p>Loading drivers...</p>
        )}
      </div>
      {selectedDriver && (
        <Modal
          driver={selectedDriver}
          onClose={() => handleDriverClick(null)}
        />
      )}
    </>
  );
}
