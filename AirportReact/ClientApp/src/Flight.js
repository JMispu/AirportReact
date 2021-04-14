import React, {Component} from "react";

class Flight extends Component{
    constructor(props) {
        super(props);
        this.state = {data: props.flight}
        this.onClick = this.onClick.bind(this);
    }
    onClick(e){
        this.props.onRemove(this.state.data)
    }

    render() {
        return(
            <div>
                <p>AirplaneID = {this.state.data.airplaneID}</p>
                <p>StartCityId = {this.state.data.startCityID}</p>
                <p><button onClick={this.onClick}>DELETE</button></p>
            </div>
        )
    }
}

export default Flight;