export default function Driver({number, name, team, driverImage, carImage}){
    console.log("driverimage=", driverImage);
    return(
        <>
            <div className="card">
                <h2>{number}.<span> {name}</span></h2>
                <img className="driver-image" src={driverImage} alt={`Picture of ${name}`}></img>
                <h3>{team}</h3>
                <img className="driver-car" src={carImage} alt={`Picture of ${team}`}></img>
            </div>
        </>
    )
}