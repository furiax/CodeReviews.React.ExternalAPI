export default function Modal({ driver, onClose }) {
  if (!driver) return null;

  return (
    <div className="modal-overlay" onClick={onClose}>
      <div className="modal-content" onClick={(e) => e.stopPropagation()}>
        <button className="close-button" onClick={onClose}>
          x
        </button>

        <h2>{driver.driverName}</h2>

        <div className="modal-body">
          <div className="modal-left">
            <img
              src={driver.driverImageLink}
              alt="Driver"
              className="driver-img"
            />
            <img src={driver.helmet} alt="Helmet" className="helmet-img" />
          </div>
          <div className="modal-right">
            <p>
              <strong>Driver Number:</strong> {driver.driverNumber}
            </p>
            <p>
              <strong>Team:</strong> {driver.team}
            </p>
            <p>
              <strong>Country:</strong> {driver.country}
            </p>
            <p>
              <strong>Grand Prix Entries:</strong> {driver.numberOfGPs}
            </p>
            <p>
              <strong>World Championships:</strong> {driver.worldChampionships}
            </p>
          </div>
        </div>
        <div className="car-image">
          <img src={driver.carImageLink} alt="Car" />
        </div>
      </div>
    </div>
  );
}
