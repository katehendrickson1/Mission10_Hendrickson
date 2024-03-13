import logo from './bowlinglogo.png';

function Header(props: any) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img className="logo" alt="logo" src={logo}></img>
      </div>
      <div className="col subtitle">
        <h1 className="header text-white">{props.title}</h1>
      </div>
    </header>
  );
}

export default Header;
