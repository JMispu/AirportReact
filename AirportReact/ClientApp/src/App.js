import React, { Component } from 'react';
import bootstrap from 'bootstrap';
import style from './App.css';

export default class App extends Component {
    //static displayName = App.name;

    render () {
        return (
            <div className={"sec2"}>
                <div className={"container"}>
                    <div className={"uplogo"}>
                        <p>Not sip me sugar in bear</p>
                        <h1>Choos song</h1>
                    </div>
                    <div className={"section"}>
                        <div className={"threblock clearfix"}>
                            <div className={"block"}>
                                <img src={""} alt={"Губки"}/>
                                <h3>Попробуй<br/>Муа Муа</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quasi, tempore!</p>
                            </div>
                            <div className={"block"}>
                                <img src={""} alt={"Губки"}/>
                                <h3>Попробуй<br/>Джага Джага</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing.</p>
                            </div>
                            <div className={"block"}>
                                <img src={""} alt={"Губки"}/>
                                <h3>Попробуй<br/>ММММ ММММ</h3>
                                <p>Lorem ipsum dolor sit amet.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
