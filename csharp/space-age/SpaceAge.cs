using System;

public class SpaceAge
{
    public SpaceAge(int seconds) => this.spaceage = seconds;

    public double OnEarth() => spaceage / earthOrbitalPeriod;

    public double OnMercury() => spaceage / mercuryOrbitalPeriod;

    public double OnVenus() => spaceage / venusOrbitalPeriod;

    public double OnMars() => spaceage / marsOrbitalPeriod;

    public double OnJupiter() => spaceage / jupiterOrbitalPeriod;

    public double OnSaturn() => spaceage / saturnOrbitalPeriod;

    public double OnUranus() => spaceage / uranusOrbitalPeriod;

    public double OnNeptune() => spaceage / neptuneOrbitalPeriod;

    private readonly int spaceage;
    private const double earthOrbitalPeriod = 31557600.0;
    private const double mercuryOrbitalPeriod = earthOrbitalPeriod * 0.2408467;
    private const double venusOrbitalPeriod = earthOrbitalPeriod * 0.61519726;
    private const double marsOrbitalPeriod = earthOrbitalPeriod * 1.8808158;
    private const double jupiterOrbitalPeriod = earthOrbitalPeriod * 11.8626;
    private const double saturnOrbitalPeriod = earthOrbitalPeriod * 29.447498;
    private const double uranusOrbitalPeriod = earthOrbitalPeriod * 84.016846;
    private const double neptuneOrbitalPeriod = earthOrbitalPeriod * 164.79132;


}