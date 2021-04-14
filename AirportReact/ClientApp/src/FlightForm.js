import React, {Component} from "react";

class FlightForm extends Component {
    constructor(props) {
        super(props);
        this.state = {aid: 0, scid: 0};

        this.onSubmit = this.onSubmit.bind(this);
        this.onAIDchange = this.onAIDchange.bind(this);
        this.onSCIDchange = this.onSCIDchange.bind(this);
    }

    onAIDchange(e) {
        this.setState({aid: e.target.value});
    }

    onSCIDchange(e) {
        this.setState({scid: e.target.value});
    }

    onSubmit(e) {
        e.preventDefault();
        var AirplaneID = this.state.aid;
        var StartCityID = this.state.scid;
        if (AirplaneID < 0 || StartCityID < 0) return;
        this.props.onFlightSubmit({airplaneID: AirplaneID, startCityID: StartCityID});
        this.setState({aid: 0, scid: 0});
    }

    render() {
        return (
            <form onSubmit={this.onSubmit}>
                <p>
                    <input type="text" placeholder={"Айди Самолёта"} value={this.state.airplaneID}
                           onChange={this.onAIDchange}/>
                </p>
                <p>
                    <input type="text" placeholder={"Айди Города"} value={this.state.startCityID}
                           onChange={this.onSCIDchange}/>
                </p>
                <input type="submit" value={"Save"}/>
            </form>
        );
    }
}

export default FlightForm;