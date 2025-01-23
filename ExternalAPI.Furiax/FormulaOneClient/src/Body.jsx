import { useState, useEffect } from "react"
import Driver from "./Driver.jsx"

export default function Body(){
    const [drivers, setDrivers] = useState(null);

    useEffect(()=>{
            fetch('https://localhost:7215/api/Formula')
                .then(res => res.json())
                .then(data => { 
                    setDrivers(data);
                    console.log("data:",data);
                });
    },[]);
    console.log("drivers:",drivers);
    return(
        <>
            <div className="drivers-grid">
                {drivers ? (
                    drivers.map((driver, index) => (
                        <Driver key={index}
                        number={driver.driverNumber}
                        name={driver.driverName}
                        team={driver.team}
                        driverImage={driver.driverImageLink}
                        carImage={driver.carImageLink}
                        />
                    ))
                ) : (<p>Loading drivers...</p>)}
            </div>
        </>
    )
}