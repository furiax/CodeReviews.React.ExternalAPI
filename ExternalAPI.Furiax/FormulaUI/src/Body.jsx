import { useState, useEffect } from "react"
import Driver from "./Driver.jsx"

export default function Body(){
    const [drivers, setDrivers] = useState(null);

    useEffect(()=>{
        fetch('https://localhost:7215/api/Formula')
        .then(res => { return res.json();})
        .then(data => { setDrivers(data);
            console.log("Drivers data: ", data);
        });
        
    },[]);
    return(
        <>
            <Driver />
        </>
    )
}