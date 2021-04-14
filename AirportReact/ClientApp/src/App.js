import React, {Component} from "react";
import FlightForm from "./FlightForm";
import Flight from "./Flight";

class App extends Component {
    constructor(props) {
        super(props);
        this.state = {flights: [], "isLoading" : true};

        this.onAddFlight = this.onAddFlight.bind(this);
        this.onRemoveFlight = this.onRemoveFlight.bind(this);
    }

    loadData() {
        var xhr = new XMLHttpRequest();
        xhr.open("get", this.props.apiUrl, true);
        xhr.onload = function () {
            var data = JSON.parse(xhr.responseText);
            this.setState({flights: data});
        }.bind(this);
        xhr.send();
    }

    componentDidMount() {
        this.loadData();
    }

    async onAddFlight(flight) {
        if (flight) {
            var request = await fetch(this.props.apiUrl, {
                method: "POST",
                headers: {
                    'Content-Type': 'application/json;charset=utf-8'
                },
                body: JSON.stringify({
                    "airplaneID": flight.airplaneID,
                    "startCityID": flight.startCityID,
                    "finishCityID": flight.startCityID,
                    "time": "2021-03-13T23:00:00"
                })
            });
            this.loadData();
            this.render();
        }
    }

    /*async onUpdateFlight(flight) {
        if (flight) {
            var request = await fetch(this.props.apiUrl, {
                method: "POST",
                headers: {
                    'Content-Type': 'application/json;charset=utf-8'
                },
                body: JSON.stringify({
                    "airplaneID": flight.airplaneID,
                    "startCityID": flight.startCityID,
                    "finishCityID": flight.startCityID,
                    "time": "2021-03-13T23:00:00"
                })
            });
            this.loadData();
            this.render();
        }
    }*/

    async onRemoveFlight(flight) {
        if (flight) {
            var request = await fetch(this.props.apiUrl + flight.id, {
                method: "DELETE",
                headers: {
                    'Content-Type': 'application/json;charset=utf-8'
                },
            });
            this.loadData();
            this.render();
        }
    }

    render() {
        var remove = this.onRemoveFlight;
        return (
            <div>
                <FlightForm onFlightSubmit={this.onAddFlight}/>
                <h2>Список Полётов</h2>
                <div>
                    {this.state.flights.map(function (flight) {
                        return <Flight key={flight.id} flight={flight} onRemove={remove}/>
                    })}
                </div>
            </div>
        )
    }
}

export default App;