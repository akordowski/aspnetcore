// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.AspNetCore.Identity;

/// <summary>
/// Represents all the options you can use to configure the identity api endpoints.
/// </summary>
public class IdentityApiOptions
{
    /// <summary>
    /// The value for the route tag.
    /// </summary>
    public string? RouteTag { get; set; }

    /// <summary>
    /// The value for the route group.
    /// </summary>
    public string RouteGroup { get; set; } = "";

    /// <summary>
    /// The value for the register endpoint.
    /// </summary>
    public string RegisterEndpoint { get; set; } = "/register";

    /// <summary>
    /// The value for the login endpoint.
    /// </summary>
    public string LoginEndpoint { get; set; } = "/login";

    /// <summary>
    /// The value for the refresh endpoint.
    /// </summary>
    public string RefreshEndpoint { get; set; } = "/refresh";

    /// <summary>
    /// The value for the confirm email endpoint.
    /// </summary>
    public string ConfirmEmailEndpoint { get; set; } = "/confirmEmail";

    /// <summary>
    /// The value for the resend confirmation email endpoint.
    /// </summary>
    public string ResendConfirmationEmailEndpoint { get; set; } = "/resendConfirmationEmail";

    /// <summary>
    /// The value for the forgot password endpoint.
    /// </summary>
    public string ForgotPasswordEndpoint { get; set; } = "/forgotPassword";

    /// <summary>
    /// The value for the reset password endpoint.
    /// </summary>
    public string ResetPasswordEndpoint { get; set; } = "/resetPassword";

    /// <summary>
    /// The value for the manage route group.
    /// </summary>
    public string ManageRouteGroup { get; set; } = "manage";

    /// <summary>
    /// The value for the 2fa endpoint.
    /// </summary>
    public string MfaEndpoint { get; set; } = "/2fa";

    /// <summary>
    /// The value for the info endpoint.
    /// </summary>
    public string InfoEndpoint { get; set; } = "/info";
}
